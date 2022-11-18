import React from 'react';
import Header from '../../Components/Header/header';
import Left from '../../Components/Left/Left';
import Center from '../../Components/Center/Center';
import Rigth from '../../Components/Rigth/Rigth';
import Footer from '../../Components/Footer/Footer';
import NavBar from '../../Components/NavBar/NavBar';

const Home = () => {
    return (
        <div className="home">
            <NavBar/>
            <Header />
            <div className="row g-0">
                <div className="col-2 columns">
                    <Left />
                </div>
                <div className="col-8 columns">
                    <Center />
                </div>
                <div className="col-2 columns">
                    <Rigth />
                </div>
            </div>
            <Footer />
        </div>
    );
}

export default Home;
