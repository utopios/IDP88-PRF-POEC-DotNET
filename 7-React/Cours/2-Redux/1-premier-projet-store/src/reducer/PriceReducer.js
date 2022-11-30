const INITIAL_STATE = {
    pric: 500
}


function PriceReducer(state = INITIAL_STATE, action) {

    switch (action.type) {
        case 'ADDPRICE':{
            return{
                ...state,
                pric: action.payload
            }

        }
        default:{
            return state;
        }
    }
}
export default PriceReducer;