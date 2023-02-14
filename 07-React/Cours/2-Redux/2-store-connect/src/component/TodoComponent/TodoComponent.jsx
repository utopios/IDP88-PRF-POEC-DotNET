import React from 'react';
import { connect } from 'react-redux';
import { toggleTodo } from '../../redux/actions/todosActions';
import { FontAwesomeIcon } from '@fortawesome/react-fontawesome';
import { faCheck } from '@fortawesome/free-solid-svg-icons';
import './TodoComponent.css'

const TodoComponent = ({ todo, key, toggleTodo }) => {
    return (
        <React.Fragment key={key}>
            <li className='todo-item' onClick={() => toggleTodo(todo.id)}>
            <FontAwesomeIcon
                icon={faCheck}
                color={todo.completed ? "green" : "red"}
            />
            <span className={todo.completed ? "todo-item-completed" : "todo-item"}>
                {todo.content}
            </span>
        </li>
        </React.Fragment>
    );
}

//export default TodoComponent;
export default connect(null, { toggleTodo })(TodoComponent)