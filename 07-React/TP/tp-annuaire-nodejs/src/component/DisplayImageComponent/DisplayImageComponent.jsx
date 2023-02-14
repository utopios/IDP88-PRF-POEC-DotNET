import React, { Component } from 'react';

class DisplayImageComponent extends Component {
    constructor(props) {
        super(props)
        this.state = {
            editImage: false
        }
    }

    changeImg = (e) => {        
        let img = document.getElementById('img').files[0];
        this.props.PostImage(this.props.id, img)
        this.setState({ editImage: false })
    }

    render() {
        return this.state.editImage === false ? (
            <img src={this.props.urlImg} alt="Contact" height="50px" onClick={() => this.setState({ editImage: true })} />
        ) : (
            <div className="input-group mb-3">
                <input type="file" name="img" id="img" className="form-control" />
                <div className="input-group-append">
                    <button onClick={() => this.changeImg()} className="btn btn-success">Changer</button>
                    <button onClick={() => this.setState({editImage: false})} className="btn btn-danger">Annuler</button>
                </div>
            </div>
        );
    }
}

export default DisplayImageComponent;