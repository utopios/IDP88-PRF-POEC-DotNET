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
export const ADD_TODO_ACTION = 'ADD_TODO_ACTION';
export const UPDATE_TODO_ACTION = 'UPDATE_TODO_ACTION';

export function TodosReducer(state = initialState, action) {
    switch (action.type) {
        // Création d'une action
        case ADD_TODO_ACTION:
            return [...state, { id: ++id, ...action.payload, completed: false }];
        case UPDATE_TODO_ACTION:
            return state.map(todo => {
                if (todo.id === action.payload.id) {
                    return { ...todo, ...action.payload }
                }else{
                    return todo
                }
            })
        default:
            return state;
    }
};