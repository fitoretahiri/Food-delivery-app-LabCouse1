import React, { Component } from 'react';
import { Modal, Button, Row, Col, Form } from 'react-bootstrap';

export class EditUserModal extends Component {
    constructor(props) {
        super(props);
        this.handleSubmit = this.handleSubmit.bind(this);
    }

    handleSubmit(event) {
        console.log(event.target.id.value)
        event.preventDefault();
        fetch(process.env.REACT_APP_API + 'user', {
            method: 'PUT',
            headers: {
                'Accept': 'application/json',
                'Content-Type': 'application/json'
            },
            body: JSON.stringify({
                userID: event.target.userID.value,
                emri: event.target.emri.value,
                mbiemri: event.target.mbiemri.value,
                photoProfile: event.target.photoProfile.value,
                password: event.target.password.value,
                confirmPsw: event.target.confirmPsw.value,
                roliID: event.target.roliID.value
            })
        })
            .then(res => res.json())
            .then((result) => {
                alert(result);
            },
                (error) => {
                    alert('Failed');
                })
    }
    render() {
        return (
            <div className="container">

                <Modal
                    {...this.props}
                    size="lg"
                    aria-labelledby="contained-modal-title-vcenter"
                    centered
                >
                    <Modal.Header closeButton>
                        <Modal.Title id="contained-modal-title-vcenter">
                            Edit Perdoruesin
                        </Modal.Title>
                    </Modal.Header>
                    <Modal.Body>

                        <Row>
                            <Col sm={6}>
                                <Form onSubmit={this.handleSubmit}>
                                    <Form.Group controlId="userID">
                                        <Form.Label>Id e perdoruesit</Form.Label>
                                        <Form.Control type="text" name="userID" required disabled
                                            defaultValue={this.props.userID}
                                            placeholder="id" />
                                    </Form.Group>
                                    <Form.Group controlId="emri">
                                        <Form.Label>Emri i perdoruesit</Form.Label>
                                        <Form.Control type="text" name="emri" required
                                            defaultValue={this.props.emri}
                                            placeholder="emri" />
                                    </Form.Group>

                                    <Form.Group controlId="mbiemri">
                                        <Form.Label>Mbimeri i perdoruesit</Form.Label>
                                        <Form.Control type="text" name="mbiemri" required
                                            defaultValue={this.props.mbiemri}
                                            placeholder="mbiemri" />
                                    </Form.Group>

                                    <Form.Group controlId="photoProfile">
                                        <Form.Label>Foto e perdoruesit</Form.Label>
                                        <Form.Control type="text" name="photoProfile" required
                                            defaultValue={this.props.photoProfile}
                                            placeholder="Foto" />
                                    </Form.Group>

                                    <Form.Group controlId="password">
                                        <Form.Label>Password</Form.Label>
                                        <Form.Control type="text" name="password" required
                                            defaultValue={this.props.password}
                                            placeholder="Password" />
                                    </Form.Group>

                                    <Form.Group controlId="confirmPsw">
                                        <Form.Label>Confirm Password</Form.Label>
                                        <Form.Control type="text" name="confrimPsw" required
                                            defaultValue={this.props.confirmPsw}
                                            placeholder="Confirm Password" />
                                    </Form.Group>

                                    <Form.Group controlId="roliID">
                                        <Form.Label>Roli i perdoruesit</Form.Label>
                                        <Form.Control type="text" name="roliID" required
                                            disabled
                                            defaultValue={this.props.roliID}
                                            placeholder="User role" />
                                    </Form.Group>
                                    <Form.Group>
                                        <Button variant="primary" type="submit">
                                            Update
                                        </Button>
                                    </Form.Group>
                                </Form>
                            </Col>
                        </Row>
                    </Modal.Body>

                    <Modal.Footer>
                        <Button variant="danger" onClick={this.props.onHide}>Close</Button>
                    </Modal.Footer>

                </Modal>

            </div>
        )
    }

}