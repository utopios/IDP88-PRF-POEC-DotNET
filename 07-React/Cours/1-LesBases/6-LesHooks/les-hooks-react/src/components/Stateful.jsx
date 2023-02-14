import React, { PureComponent } from 'react';

class Stateful extends PureComponent {

    constructor(props) {
        super(props)
        this.state = {
            count: 0
        }
    }

    setCount = (value) => {
        this.setState({
            count: value
        })
    }

    componentDidMount() {
        // Mettre à jour le titre du document en utilisant l'API du navigateur
        document.title = `Vous avez cliqué ${this.state.count} fois`;
    }

    componentDidUpdate(prevState, prevProps) {
        if (prevState.count !== this.state.count)
            // Mettre à jour le titre du document en utilisant l'API du navigateur
            document.title = `Vous avez cliqué ${this.state.count} fois`;
    }



    render() {
        return (
            <div>
                <p>Stateful =&gt; Vous avez cliqué {this.state.count} fois</p>
                <button onClick={() => this.setState({ count: this.state.count + 1 })}>
                    Incrémenter
                </button>
                <button onClick={() => this.setState({ count: 0 })}>
                    Reset
                </button>
            </div>
        );
    }
}

export default Stateful;