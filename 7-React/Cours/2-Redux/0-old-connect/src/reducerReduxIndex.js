
/**
 * Création d'un store Redux
 * 
 * npm install redux 
 *        &
 * Ajouter import en haut du fichier
 */

import {createStore} from 'redux' // Cette méthode prend en premier parametre le reducer et nous retourne un store

let id = 2;

const initialState = [
  {
    id: 1,
    title: 'Apprendre Redux',
    completed: false
  },
  {
    id: 2,
    title: 'Créer un store Redux',
    completed: true
  }
];
// Définition des Actions
const ADD_TODO_ACTION = 'ADD_TODO_ACTION';


// Un reducer C'est une fonction qui prendra en parametre un etat et une action
// et en fonction de cette action, il va changer l'état
function TodoReducer(state = initialState, action) {
  switch (action.type) {
    // Création d'une action
    case ADD_TODO_ACTION:
      return [...state, {id: ++id, ...action.payload,  completed:false}];
    default:
      return state;
  }
};

/**
 * Création du store => createStore(<Reducer>)
 */
const store = createStore(TodoReducer)


// Abonnement au store grace à la fonction subscribe qui est déclenché à chaque changement de state du store
// qui grace à une fonction lambda, retourne le state du store => fonction getState() de redux
store.subscribe(()=> console.log(store.getState()))


// Interraction avec le store => <instance>.dispatch( <action>,<payload> )
store.dispatch({type: ADD_TODO_ACTION, payload:{title:"J'ajoute une Todo"}})
store.dispatch({type: ADD_TODO_ACTION, payload:{title:"J'ajoute une Todo"}})
store.dispatch({type: ADD_TODO_ACTION, payload:{title:"J'ajoute une Todo"}})
store.dispatch({type: ADD_TODO_ACTION, payload:{title:"J'ajoute une Todo"}})
store.dispatch({type: ADD_TODO_ACTION, payload:{title:"J'ajoute une Todo"}})
store.dispatch({type: ADD_TODO_ACTION, payload:{title:"J'ajoute une Todo"}})
store.dispatch({type: ADD_TODO_ACTION, payload:{title:"J'ajoute une Todo"}})