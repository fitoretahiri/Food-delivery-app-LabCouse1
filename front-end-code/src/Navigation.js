import React,{Component} from 'react';
import {NavLink} from 'react-router-dom';
import {Navbar,Nav} from 'react-bootstrap';
import { Link } from 'react-router-dom';

export class Navigation extends Component{


    render(){
        return(
            <Navbar bg="dark" expand="lg">
                <Navbar.Toggle aria-controls="basic-navbar-nav"/>
                <Navbar.Collapse id="basic-navbar-nav">
                <Nav>
                <Link to="/" className="d-inline p-2 bg-dark text-white">Home</Link>
                <Link to="/restoranti" className="d-inline p-2 bg-dark text-white">Restorantet</Link>
                    <Link to="/qyteti" className="d-inline p-2 bg-dark text-white">Qytetet</Link>
                    <Link to="/user" className="d-inline p-2 bg-dark text-white">Perdoruesit</Link>
                        <Link to="/menu" className="d-inline p-2 bg-dark text-white">Menu</Link>
                        <Link to="/role" className="d-inline p-2 bg-dark text-white">Roli</Link>

                </Nav>
                </Navbar.Collapse>
            </Navbar>
        );
    }
}