import { connect } from "react-redux"
// import { UPDATE_TODO_ACTION } from "../store/todosReducer"
import { todosSelector } from "../store/todosSelectors"
import { toggleTodoAction } from "../store/todosActions"

function TodoItem({ todo, onToggle }) {
    return <li>
        <label htmlFor="">
            <input type="checkbox" checked={todo.completed} onChange={() => onToggle(todo)} />
            {todo.title}
        </label>
    </li>
}

function TodoList({ todos, onToggle }) {
    // return "TodoList";
    // return JSON.stringify(todos);
    return <ul>
        {todos.map(todo => <TodoItem todo={todo} onToggle={onToggle} key={todo.id} />)}
    </ul>
}

export const TodoListStore = connect(
    (state) => ({
        // // Sans le fichier todoSelector.js
        //todos: state.todos

        // Avec le fichier todoSelector.js
        todos: todosSelector(state)
    }),
    (dispatch) => ({
        // // Sans le fichier todoAction.js
        // onToggle: todo => dispatch({
        //     type: UPDATE_TODO_ACTION,
        //     payload: { ...todo, completed: !todo.completed }
        // })
        // Avec le fichier todoActions.js
        onToggle: todo => dispatch(toggleTodoAction(todo))
        })
)(TodoList)