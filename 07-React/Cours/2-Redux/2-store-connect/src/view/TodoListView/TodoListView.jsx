import React from 'react';
import AddTodoComponent from '../../component/AddTodoComponent/AddTodoComponent'
import FilterListComponent from '../../component/FilterListComponent/FilterListComponent'
import TodoListComponent from '../../component/TodoListComponent/TodoListComponent'
import './TodoListView.css'

const TodoListView = () => {
    return (
        <div>
            <div className="title">
                <h1>TodoList React Redux</h1>
            </div>
            <AddTodoComponent/>
            <FilterListComponent/>
            <TodoListComponent/>
        </div>
    );
}

export default TodoListView;
