import React, { Component } from 'react';
import { Table } from 'react-bootstrap';
import { Button, ButtonToolbar } from 'react-bootstrap';
import { AddUserModal } from './AddUserModal';
import { EditUserModal } from './EditUserModal';
import { Navigation } from './Navigation';


export class Useri extends Component {
    constructor(props) {
        super(props);
        this.state = {users: [], addModalShow: false }
    }

    //marrja e te dhenave nga API
    refreshList() {
        fetch(process.env.REACT_APP_API + 'user')
            .then(response => response.json())
            .then(data => {
                this.setState({users: data });
            });
    }

    componentDidMount() {
        this.refreshList();
    }

    componentDidUpdate() {
        this.refreshList();
    }

    //delete a user
    deleteUser(id) {
        if (window.confirm('A doni ta fshini perdoruesin?')) {
            fetch(process.env.REACT_APP_API + 'user/' + id, {
                method: 'DELETE',
                header: {
                    'Accept': 'application/json',
                    'Content-Type': 'application/json'
                }
            })
        }
    }

    render() {
        const { users, userID, emri, mbiemri, photoProfile, password, confirmPsw, roliID } = this.state;
        let addModalClose = () => this.setState({ addModalShow: false });
        let editModalClose = () => this.setState({ editModalShow: false });
        return (
            <div className="user mt-5">
<<<<<<< Updated upstream
                <Navigation />
=======
                <Navigation/>
>>>>>>> Stashed changes
                <Table className="mt-4" striped bordered hover size="sm">
                    <thead>
                        <tr>
                            <th>Emri</th>
                            <th>Mbiemri</th>
                            <th>Foto</th>
                            <th>Password</th>
                            <th>Confirm Password</th>
                            <th>Roli</th>
                            <th>Options</th>
                        </tr>
                    </thead>
                    <tbody>
                        {users.map(el =>
                            <tr key={el.userID}>
                                <td>{el.emri}</td>
                                <td>{el.mbiemri}</td>
                                <td>{el.photoProfile}</td>
                                <td>{el.password}</td>
                                <td>{el.confirmPsw}</td>
                                <td>{el.roli.role}</td>
                                <td>
                                    <ButtonToolbar>
                                        <Button className="mr-2" variant="info"
                                            onClick={() => this.setState({
                                                editModalShow: true,
                                                userID: el.userID, emri: el.emri, mbiemri: el.mbiemri, photoProfile: el.photoProfile, password: el.password, confirmPsw: el.confirmPsw, roliID: el.roliID
                                            })}>
                                            Edit
                                        </Button>

                                        <Button className="mr-2" variant="danger"
                                            onClick={() => this.deleteUser(el.userID)}>
                                            Delete
                                        </Button>

                                        <EditUserModal show={this.state.editModalShow}
                                            onHide={editModalClose}
                                            userID={userID}
                                            emri={emri}
                                            mbiemri={mbiemri}
                                            photoProfile={photoProfile}
                                            password={password}
                                            confirmPsw={confirmPsw}
                                            roliID={roliID} />
                                    </ButtonToolbar>

                                </td>

                            </tr>)}
                    </tbody>

                </Table>
                <ButtonToolbar>
                    <div className="d-grid gap-2">
                        <Button variant='primary' size='lg'
                            onClick={() => { this.setState({ addModalShow: true }) }}>
                            Shto Perdoruesin
                        </Button>
                    </div>
                    <AddUserModal show={this.state.addModalShow}
                        onHide={addModalClose}
                    />
                </ButtonToolbar>
            </div>
        )
    }
}