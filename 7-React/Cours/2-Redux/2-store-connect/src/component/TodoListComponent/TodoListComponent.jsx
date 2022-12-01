import React from 'react';
import TodoComponent from '../TodoComponent/TodoComponent'
import { connect } from 'react-redux';
import { getTodos } from '../../redux/selectors/todoSelector'
import './TodoListComponent.css';

const TodoListComponent = ({ todos }) => {
    return (
        <div className='container-list'>
            <ul className='todo-list'>
                {todos.length ?
                    todos.map((todo) => {
                       return <TodoComponent key={todo.id} todo={todo} />
                    }) : (
                        <span>Il n'y rien dans la liste!</span>
                    )
                }

            </ul>
        </div>
    );


}
const mapStateToProps = state => {
    const todos = getTodos(state);
    return { todos };
}
export default connect(mapStateToProps)(TodoListComponent)
//export default TodoListComponent;
