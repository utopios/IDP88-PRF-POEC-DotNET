import { SET_FILTER } from '../constants/actionstype';
import { VISIBILITY_FILTER } from '../constants/Visibility';

const initialState = VISIBILITY_FILTER.ALL;

const visibilityFilter = (state = initialState , action) =>{
    switch(action.type){
        case SET_FILTER: {
            return action.payload.filter;
        }
        default:{
            return state
        }
    }
}

export default visibilityFilter;