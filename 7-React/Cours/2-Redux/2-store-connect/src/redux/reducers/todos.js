import { ADD_TODO, TOGGLE_TODO } from '../constants/actionstype';

const initialState = {
    allIds: [1, 2, 3],
    byIds: {
        1: { content: "Apprendre Redux", completed: false },
        2: { content: "Faire des exercices", completed: false },
        3: { content: "Construire un projet", completed: false }
    }
}
// eslint-disable-next-line 
export default function (state = initialState, action) {
    switch (action.type) {
        case ADD_TODO: {
            const { id, content } = action.payload;
            return {
                ...state,
                allIds: [...state.allIds, id],
                byIds: {
                    ...state.byIds,
                    [id]: {
                        content,
                        completed: false
                    }
                }
            };
        }
        case TOGGLE_TODO: {
            const { id } = action.payload;
            return {
                ...state,
                byIds: {
                    ...state.byIds,
                    [id]: {
                        ...state.byIds[id],
                        completed: !state.byIds[id].completed
                    }
                }
            };
        }
        default:
            return state;

    }
}