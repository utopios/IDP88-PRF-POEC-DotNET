/**
 * Reducer => a faire dans le index.js
 */

console.log("Reducer en JavaScript");

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

// Affichage de la liste initial test
const state = TodoReducer(undefined,{});
// Ajout d'une todo par le reducer
const newState = TodoReducer(state, {type:ADD_TODO_ACTION, payload:{title:"J'ajoute une todo"}})
// Affichage des states
console.log(state,newState);