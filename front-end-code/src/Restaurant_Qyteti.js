import React, { Component } from 'react';
import { Table } from 'react-bootstrap';
import { Button, ButtonToolbar } from 'react-bootstrap';
//import { AddQytetinModal } from './AddQytetinModal';
//import { EditQytetinModal } from './EditQytetinModal';
import { Navigation } from './Navigation';


export class Restaurant_Qyteti extends Component {
    constructor(props) {
        super(props);
        this.state = { lidhjet: [], addModalShow: false }
    }

    //marrja e te dhenave nga API
    refreshList() {
        fetch(process.env.REACT_APP_API + 'restaurant_qyteti')
            .then(response => response.json())
            .then(data => {
                this.setState({ lidhjet: data });
            });
    }

    componentDidMount() {
        this.refreshList();
    }

    componentDidUpdate() {
        this.refreshList();
    }

<<<<<<< HEAD
    deleteLidhja(id1, id2) {
        if (window.confirm('A doni ta fshini kete lokacion?')) {
            fetch((process.env.REACT_APP_API + 'restaurant_qyteti/' + id1) + (process.env.REACT_APP_API + 'restaurant_qyteti/' + id2), {
=======
    deleteLidhja(id) {
        if (window.confirm('A doni ta fshini kete lokacion?')) {
            fetch(process.env.REACT_APP_API + 'restaurant_qyteti/' + id, {
>>>>>>> login_functionality_branch
                method: 'DELETE',
                header: {
                    'Accept': 'application/json',
                    'Content-Type': 'application/json'
                }
            })
        }
    }

    render() {
<<<<<<< HEAD
        const { lidhjet, restaurantID, qytetiID } = this.state;
=======
        const { lidhjet, id, restaurantID, qytetiID } = this.state;
>>>>>>> login_functionality_branch
        let addModalClose = () => this.setState({ addModalShow: false });
        let editModalClose = () => this.setState({ editModalShow: false });
        return (
            <div className="mt-5">
                <Navigation />
                <Table className="mt-4" striped bordered hover size="sm">
                    <thead>
                        <tr>
<<<<<<< HEAD
=======
                            <th>Id</th>
>>>>>>> login_functionality_branch
                            <th>Restauranti</th>
                            <th>Qyteti</th>
                        </tr>
                    </thead>
                    <tbody>
                        {lidhjet.map(el =>
<<<<<<< HEAD
                            <tr key={el.restaurantID}>
                                <td>{el.restaurantID}</td>
                                <td>{el.qytetiID}</td>
                                <td>
                                    <ButtonToolbar>

                                        <Button className="mr-2" variant="danger"
                                            onClick={() => this.deleteLidhja(el.restaurantID, el.qytetiID)}>
                                            Delete
                                        </Button>
                                    </ButtonToolbar>
=======
                            <tr key={el.id}>
                                <td>{el.id}</td>
                                <td>{el.restaurantID}</td>
                                <td>{el.qytetiID}</td>
                                <td>

>>>>>>> login_functionality_branch
                                </td>
                            </tr>)}
                    </tbody>

                </Table>

            </div>
        )
    }
}