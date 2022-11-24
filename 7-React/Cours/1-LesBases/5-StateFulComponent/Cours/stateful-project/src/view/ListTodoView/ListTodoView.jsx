import React, { PureComponent } from 'react';
import FormTodoComponent from '../../component/FormTodoComponent/FormTodoComponent';
import ListTodoComponent from '../../component/ListTodoComponent/ListTodoComponent';

class ListTodoView extends PureComponent {

    constructor(props) {
        super(props)
        this.state = {
            todos: []
        }
    }

    addTodo = (text) => {
        //alert(text);
        let todosTmp = [...this.state.todos];
        let newTodo = {
            id: (this.state.todos[this.state.todos.length - 1] !== undefined) ? (this.state.todos[this.state.todos.length - 1].id + 1) : 1,
            status: 'undone',
            content: text
        };
        todosTmp.push(newTodo)
        this.setState({
            todos: todosTmp
        })
    }

    deleteTodo = (id) => {
        let todosTmp = [];
        for (let todo of this.state.todos) {
            if (todo.id !== id)
                todosTmp.push(todo);
        }
        this.setState({
            todos: todosTmp
        })
    }

    editTodo = (id, newContent) => {
        let todosTmp = [];
        for (let todo of this.state.todos) {
            if (todo.id === id)
                todo.content = newContent
            todosTmp.push(todo);
        }
        this.setState({
            todos: todosTmp
        })
    }

    changeStatus = (id, newStatus) => {
        let todosTmp = [];
        for (let todo of this.state.todos) {
            if (todo.id === id)
                todo.status = newStatus
            todosTmp.push(todo);
        }
        this.setState({
            todos: todosTmp
        })
    }

    render() {
        return (
            <div>
                <h1>React Todo List </h1>
                <FormTodoComponent addTodo={this.addTodo} />
                {
                    this.state.todos.map((todo, index) => {
                        return (
                            <ListTodoComponent
                                key={index}
                                deleteTodo={this.deleteTodo}
                                editTodo={this.editTodo}
                                changeStatus={this.changeStatus}
                                todo={todo}
                            />
                        )
                    })
                }
            </div>
        );
    }
}

export default ListTodoView;
