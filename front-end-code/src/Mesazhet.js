import React, { Component } from 'react';
import { Table } from 'react-bootstrap';
import { Button, ButtonToolbar } from 'react-bootstrap';
import { AddMenuModal } from './AddMenuModal';
import { EditMenuModal } from './EditMenuModal';
import { Navigation } from './Navigation';


const Mesazhet = () => {
    return ( 
        <div className="restaurant mt-5">
                <Navigation />
                <Table className="mt-4" striped bordered hover size="sm">
                    <thead>
                        <tr>
                            <th>Id</th>
                            <th>Subjekti</th>
                            <th>Mesazhi</th>
                            <th>Email i Përdorues</th>
                            <th>Username iPerdoruesit</th>
                            <th>ID e Perdoruesit</th>
                        </tr>
                    </thead>
                    <tbody>
                            <tr>
                                <td>1</td>
                                <td>Lorem ipsum</td>
                                <td>Lorem Ipsum Lorem Ipsum Lorem Ipsum Lorem Ipsum Lorem Ipsum Lorem Ipsum Lorem Ipsum Lorem Ipsum</td>
                                <td>res1@gmail.com</td>
                                <td>res1</td>
                                <td>1</td>
                                <td>
                                    <ButtonToolbar>
                                        <Button className="mr-2" variant="danger">
                                            Delete
                                        </Button>

                                    
                                    </ButtonToolbar>
                                </td>
                            </tr>
                    </tbody>

                </Table>
            </div>
     );
}
 
export default Mesazhet;