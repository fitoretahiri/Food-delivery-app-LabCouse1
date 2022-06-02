import React, { Component } from 'react';
import { Modal, Button, Row, Col, Form } from 'react-bootstrap';

export class AddUserModal extends Component {
    constructor(props) {
        super(props);
        this.handleSubmit = this.handleSubmit.bind(this);
        this.state = { roles: [], addModalShow: false }
    }

    //marrja e te dhenave nga API
    refreshList() {
        fetch(process.env.REACT_APP_API + 'role')
            .then(response => response.json())
            .then(data => {
                this.setState({ roles: data });
            });
    }

    componentDidMount() {
        this.refreshList();
    }

    componentDidUpdate() {
        this.refreshList();
    }
    handleSubmit(event) {
        event.preventDefault();
        let rolet = this.state.roles;
        let roli = event.target.role.value;
        let roliID;
        for(let i = 0; i<rolet.length; i++){
            if(roli === rolet[i].role){
                roliID = rolet[i].roliID
            }
        }

        fetch(process.env.REACT_APP_API + 'user', {
            method: 'POST',
            headers: {
                'Accept': 'application/json',
                'Content-Type': 'application/json'
            },
            body: JSON.stringify({
                emri: event.target.emri.value,
                mbiemri: event.target.mbiemri.value,
                photoProfile: 'fakepath',
                password: event.target.password.value,
                confirmPsw: event.target.confirmPsw.value,
                roliID: roliID
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
        const { roles, roliID, role } = this.state;
        
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
                                    <Form.Group controlId="role">
                                        <Form.Label>Roli id</Form.Label>
                                        <Form.Control as="select" name="role" className='mb-3' required
                                            placeholder="Role">
                                            {roles.map(el =>
<<<<<<< Updated upstream
                                                <option>{el.role}</option>)
                                            }
=======
                                
                                                <option>{el.role}</option>)}
>>>>>>> Stashed changes
                                        </Form.Control>

                                    </Form.Group>

                                    <Form.Group>
                                        <Button variant="primary mt-5" type="submit">
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