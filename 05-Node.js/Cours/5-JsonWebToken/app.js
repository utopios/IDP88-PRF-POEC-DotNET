const jwt = require('jsonwebtoken');
require('dotenv').config();
const morgan = require('morgan');
const {M2iFunction} = require('./helper.js');
const ip = require('ip');

const express = require('express');
const app = express();
const port = 3000;
const ipAddress = ip.address();
app
  .use(express.json())
  .use(express.urlencoded({ extended: true }))
  .use(morgan('dev'))

const user = {
  id: 42,
  name: 'Jean bon',
  email: 'jeanbon@gmail.com',
  password: 'cuillere',
  admin: true,
};

/**
 *  FUNCTION()
 */

function generateAccessToken(user) {
  return jwt.sign(user, process.env.ACCESS_TOKEN_SECRET, { expiresIn: '1800s' });
}


function generateRefreshToken(user) {
  return jwt.sign(user, process.env.REFRESH_TOKEN_SECRET, { expiresIn: '1y' });
}

function authenticateToken(req, res, next) {
  //console.log(req);
  const authHeader = req.headers['authorization'];
  const token = authHeader && authHeader.split(' ')[1];

  if (!token) {
    return res.sendStatus(401);
  }

  jwt.verify(token, process.env.ACCESS_TOKEN_SECRET, (err, user) => {
    if (err) {
      return res.sendStatus(401);
    }
    req.user = user;
    next();
  });
}

/**
 * END POINTS
 */

app.post('/api/login', (req, res) => {
  // TODO: checker en BDD le user par rapport à l'email
  if (req.body.email != user.email || req.body.password !== user.password) {
    res.status(401).send('invalid credentials');
    return;
  }


  const accessToken = generateAccessToken(user);
  const refreshToken = generateRefreshToken(user);
  res.send({
    accessToken,
    refreshToken,
  });

});

app.post('/api/refreshToken', (req, res) => {
  const authHeader = req.headers['authorization'];
  const token = authHeader && authHeader.split(' ')[1];//Convention de nomage
  console.log(token);

  if (!token) {
    return res.sendStatus(401);
  }

  jwt.verify(token, process.env.REFRESH_TOKEN_SECRET, (err, user) => {
    if (err) {
      return res.sendStatus(401);
    }
    // TODO : check en bdd que le user a toujours les droits et qu'il existe toujours
    delete user.iat;
    delete user.exp;
    const refreshedToken = generateAccessToken(user);
    res.send({
      accessToken: refreshedToken,
    });
  });
});



app.get('/api/me', authenticateToken, (req, res) => {
  res.send(req.user);
});

app.listen(port, () => { console.log(M2iFunction(port,ipAddress)) });