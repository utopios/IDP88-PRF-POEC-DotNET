import React, { Component } from 'react';
import { connect } from 'react-redux';
import { addTodo } from '../../redux/actions/todosActions';
import './AddTodoComponent.css';

class AddTodoComponent extends Component {

    constructor(props) {
        super(props)
        this.state = {
            newTodo: ""
        }
    }

    setNewTodo = newTodo => {
        this.setState({
            newTodo
        })
    }

    handleAddTodo = () => {
        if (this.state.newTodo !== ""){
            this.props.addTodo(this.state.newTodo);
            this.setState({
                newTodo:""
            })
        }

    }

    render() {
        return (
            <div className='center-block'>
                <div className="input-group">
                    <input
                        type="text" 
                        className='form-control'
                        placeholder='Veuillez saisir une todo...'
                        onChange={e => this.setNewTodo(e.target.value)}
                        value={this.state.newTodo}
                    />
                    <div className="input-group-append">
                        <button className='btn btn-success' onClick={()=>this.handleAddTodo()}>
                            Add todo
                        </button>
                    </div>
                </div>
            </div>
        );
    }
}

//export default AddTodoComponent;
export default connect(null, { addTodo })(AddTodoComponent)

