import React, { PureComponent } from "react";
import "./DisplayLineComponent.css";


export default class DisplayLineComponent extends PureComponent {
    constructor(props) {
        super(props);
        this.state = {
            
        };
    }

   
    render() {
        return (
            <React.Fragment key={this.props.index}>
                <tr>
                    <th>{this.props.index+1}</th>
                    <td>{this.props.person}</td>
                </tr>
            </React.Fragment>
        )
    }
}

