import React, { Component } from 'react';
import { Table } from 'react-bootstrap';
import {Button, ButtonToolbar} from 'react-bootstrap';
import { AddRestorantModal } from './AddRestorantModal';


export class Restoranti extends Component {
    constructor(props) {
        super(props);
        this.state = { restorantet: [], addModalShow: false}
    }

    //marrja e te dhenave nga API
    refreshList() {
        fetch(process.env.REACT_APP_API + 'restoranti')
            .then(response => response.json())
            .then(data => {
                this.setState({ restorantet: data });
            });
    }

    componentDidMount() {
        this.refreshList();
    }

    componentDidUpdate() {
        this.refreshList();
    }

    render() {
        const { restorantet } = this.state;
        let addModalClose=()=>this.setState({addMocalShow:false})
        return (
            <div className="mt-5 d-flex justify-content-left">
                <Table className="mt-4" striped bordered hover size="sm">
                    <thead>
                        <tr>
                            <th>Emri</th>
                            <th>Qyteti</th>
                            <th>Adresa</th>
                            <th>Nr.Kontaktues</th>
                            <th>Options</th>
                        </tr>
                    </thead>
                    <tbody>
                        {restorantet.map(el =>
                            <tr key={el.Id}>
                                <td>{el.emri}</td>
                                <td>{el.qyteti}</td>
                                <td>{el.adresa}</td>
                                <td>{el.nr_kontaktues}</td>
                                <td>Edit/Delete</td>

                            </tr>)}
                    </tbody>

                </Table>
                <ButtonToolbar>
                    <Button variant='primary'
                    onClick={()=>{this.setState({addModalShow:true})}}>Shto Restorantin</Button>
                    <AddRestorantModal show={this.state.addModalShow}
                    onHide={addModalClose}></AddRestorantModal>
                </ButtonToolbar>
            </div>
        )
    }
}