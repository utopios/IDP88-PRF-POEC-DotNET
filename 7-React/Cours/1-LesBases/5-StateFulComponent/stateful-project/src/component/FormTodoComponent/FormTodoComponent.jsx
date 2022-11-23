import React, { PureComponent } from 'react';

class FormTodoComponent extends PureComponent {

    constructor(props) {
        super(props)
        this.state = {
            contentTask: ""
        }
    }

    submit = (e) => {
        e.preventDefault();
        if(this.state.contentTask !== ""){
            this.props.addTodo(this.state.contentTask);
            this.setState({
                contentTask: ""
            });


        }else{
            alert("Veuillez saisir un texte");
        }
    }

    ChangeTaskContent = (e) =>{
        e.preventDefault();
        this.setState({
            contentTask: e.target.value
        })
    }

    render() {
        return (
            <form className='row m-1' onSubmit={this.submit}>
                <div className="col-9">
                    <input type="text" className='form-control' onChange={this.ChangeTaskContent} placeholder="Contenu de la todo..." value={this.state.contentTask}/>
                </div>
                <div className="col-3" >
                    <button type='submit' className='form-control btn btn-secondary'>Ajouter</button>
                </div>
            </form>
        );
    }
}

export default FormTodoComponent;
