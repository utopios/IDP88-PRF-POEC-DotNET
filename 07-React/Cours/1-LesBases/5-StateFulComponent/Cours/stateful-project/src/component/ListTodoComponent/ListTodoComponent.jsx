import React, { PureComponent } from 'react';
import { FontAwesomeIcon } from '@fortawesome/react-fontawesome'
import { faTrash, faPenToSquare, faCheck } from '@fortawesome/free-solid-svg-icons'

class ListTodoComponent extends PureComponent {

    constructor(props) {
        super(props)
        this.state = {
            edit: false,
            editTodoContent: ""
        }
    }

    changeStatus = () => {
        const status = this.props.todo.status === 'done' ? 'undone' : 'done';
        this.props.changeStatus(this.props.todo.id, status);
        this.forceUpdate();
    }

    doneOrUndoneButton = () => {
        return this.props.todo.status === 'done' ?
            <FontAwesomeIcon
                icon={faCheck}
                onClick={() => {
                    this.changeStatus(this.props.todo.id)
                }}
                style={{
                    fontWeight: 'bold',
                    color: 'green',
                    fontSize: '30px'
                }}
            />
            :
            <FontAwesomeIcon
                icon={faCheck}
                onClick={() => {
                    this.changeStatus(this.props.todo.id)
                }}
                style={{
                    fontWeight: 'bold',
                    color: 'red',
                    fontSize: '30px'
                }}
            />
    }

    validEditTodo = (e) => {
        e.preventDefault();
        this.props.editTodo(this.props.todo.id, this.state.editTodoContent);
        this.setState({
            edit: false
        })
    }

    EditTodo = () => {
        return (
            <form onSubmit={this.validEditTodo} className='col-9'>
                <input
                    type="text"
                    className='form-control'
                    defaultValue={this.props.todo.content}
                    onChange={(e) => {
                        this.setState({
                            editTodoContent: e.target.value
                        })
                    }}
                />
            </form>
        )
    }

    renderTodo = () => {
        return this.state.edit === false ? this.renderContentTodo() : this.EditTodo()
    }

    renderContentTodo = () => {
        return(
            <div onClick={this.changeStatus} className={(this.props.todo.status === 'done') ? 'btn col-9 text-success' : 'btn col-9 text-danger'}>
                {this.props.todo.content}
            </div>
        )
    }

    render() {
        return (
            <div className='row'>
                <div className="col-9">
                    {this.renderTodo()}
                </div>
                <div className="col-1">
                    {this.doneOrUndoneButton()}
                </div>
                <div className="col-1">
                    <FontAwesomeIcon
                        icon={faPenToSquare}
                        onClick={() => {
                            this.setState({
                                edit: true
                            })
                        }}
                        style={{
                            fontSize: '25px'
                        }}
                    />
                </div>
                <div className="col-1">
                    <FontAwesomeIcon
                        icon={faTrash}
                        onClick={() => {
                            this.props.deleteTodo(this.props.todo.id)
                        }}
                        style={{
                            fontSize: '25px'
                        }}
                    />
                </div>

            </div>
        );
    }
}

export default ListTodoComponent;
