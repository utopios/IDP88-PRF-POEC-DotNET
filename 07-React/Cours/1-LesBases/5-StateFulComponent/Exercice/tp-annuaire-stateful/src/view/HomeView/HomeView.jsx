import React, { Component } from 'react';
import { FontAwesomeIcon } from '@fortawesome/react-fontawesome';
import {
    faHome,
    faAddressCard,
    faBatteryEmpty,
    faBatteryQuarter,
    faBatteryHalf,
    faBatteryThreeQuarters,
    faBatteryFull,
    faEnvelope
} from "@fortawesome/free-solid-svg-icons";



class HomeView extends Component {
    constructor(props) {
        super(props)
    }

    render() {
        return (
            <div>
                <h1>Tp Annuaire StateFul - Bootstrap - FontAwesome</h1>
                <div>
                    <div>
                        <FontAwesomeIcon icon={faBatteryEmpty} style={{ padding: '10px', color: 'red', fontSize: '45px' }} />
                        <FontAwesomeIcon icon={faBatteryQuarter} style={{ padding: '10px', color: 'rgb(40, 44, 52)', fontSize: '45px' }} />
                        <FontAwesomeIcon icon={faBatteryHalf} style={{ padding: '10px', color: 'rgb(40, 44, 52)', fontSize: '45px' }} />
                        <FontAwesomeIcon icon={faBatteryThreeQuarters} style={{ padding: '10px', color: 'rgb(40, 44, 52)', fontSize: '45px' }} />
                        <FontAwesomeIcon icon={faBatteryFull} style={{ padding: '10px', color: 'green', fontSize: '45px' }} />
                    </div>
                    <div>
                        <FontAwesomeIcon icon={faAddressCard} style={{ padding: '10px' }} />
                        <FontAwesomeIcon icon={faEnvelope} style={{ padding: '10px' }} />
                    </div>
                    <div>
                        <FontAwesomeIcon icon={faHome} style={{ padding: '10px' }} />
                        <FontAwesomeIcon icon={faHome} transform="down-4 grow-2.5" style={{ padding: '10px' }} />
                        <FontAwesomeIcon icon={faHome} style={{ padding: '10px', color: 'red', fontSize: '25px' }} />
                    </div>
                </div>
            </div>
        );
    }
}

export default HomeView;

