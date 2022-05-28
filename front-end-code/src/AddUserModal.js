import React, { Component } from 'react';
import { Modal, Button, Row, Col, Form } from 'react-bootstrap';

export class AddUserModal extends Component {
    constructor(props) {
        super(props);
        this.handleSubmit = this.handleSubmit.bind();
    }

    handleSubmit(event) {
        event.preventDefault();
        fetch(process.env.REACT_APP_API + 'user', {
            method: 'POST',
            headers: {
                'Accept': 'application/json',
                'Content-Type': 'application/json'
            },
            body: JSON.stringify({
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
                    <Modal.Header clooseButton>
                        <Modal.Title id="contained-modal-title-vcenter">
                            Shto Perdoruesin
                        </Modal.Title>
                    </Modal.Header>
                    <Modal.Body>

                        <Row>
                            <Col sm={6}>
                                <Form onSubmit={this.handleSubmit}>
                                    <Form.Group controlId="emri">
                                        <Form.Label>Emri Perdoruesit</Form.Label>
                                        <Form.Control type="text" name="emri" required
                                            placeholder="Emri Perdoruesit" />
                                    </Form.Group>
                                    <Form.Group controlId="mbiemri">
                                        <Form.Label>Mbiemri</Form.Label>
                                        <Form.Control type="text" name="mbiemri" required
                                            placeholder="Mbiemri i Perdoruesit" />
                                    </Form.Group>
                                    <Form.Group controlId="photoProfile">
                                        <Form.Label>Foto</Form.Label>
                                        <Form.Control type="text" name="photoProfile" required
                                            placeholder="Foto" />
                                    </Form.Group>
                                    <Form.Group controlId="password">
                                        <Form.Label>Password</Form.Label>
                                        <Form.Control type="text" name="password" required
                                            placeholder="Password" />
                                    </Form.Group>
                                    <Form.Group controlId="confirmPsw">
                                        <Form.Label>Confirm Password</Form.Label>
                                        <Form.Control type="text" name="confirmPsw" required
                                            placeholder="Confirm Password" />
                                    </Form.Group>
                                    <Form.Group controlId="roliID">
                                        <Form.Label>Roli id</Form.Label>
                                        <Form.Control type="text" name="roliID" required
                                            placeholder="Role" />
                                    </Form.Group>

                                    <Form.Group>
                                        <Button variant="primary" type="submit">
                                            Shto
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