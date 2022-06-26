﻿import { Link, useParams } from "react-router-dom";
import React, { Component } from "react";
import { Navigation } from './Navigation';

export class OrderFood extends Component {
    constructor(props) {
        //const { id } = useParams();
        const words = window.location.pathname.split("/");
        super(props);
        this.state = { menus: [], addModalShow: false, editModalShow: false, id: words[2]}
    }

    //marrja e te dhenave nga API
    refreshList() {
        fetch(process.env.REACT_APP_API + 'menu/' + this.state.id)
            .then(response => response.json())
            .then(data => {
                this.setState({ menus: data });
            });
    }

    componentDidMount() {
        this.refreshList();
    }

    componentDidUpdate() {
        this.refreshList();
    }


    render() {
        const { menus, menuID, emertimi,cmimi, pershkrimi} = this.state;
        let addModalClose = () => this.setState({ addModalShow: false });
        return (
            <>

                <form className="d-flex w-100 mt-4" role="search">
                    <input className="form-control me-2 border-3" type="search" placeholder="Search" aria-label="Search" />
                    <button className="btn btn-outline-success" type="submit">Search</button>
                </form>

                <div className="row row-cols-1 row-cols-md-3 g-4">
                    <div className="w-25 p-3 g-5">
                        <ul className="list-group">
                            <li className="list-group-item">
                                Filtro sipas cmimi
                            </li>
                            <li className="list-group-item">
                                <input className="form-check-input me-1" type="checkbox" value="" aria-label="..." /> deri ne 10 €
                            </li>
                            <li className="list-group-item">
                                <input className="form-check-input me-1" type="checkbox" value="" aria-label="..." /> me shume se 10 €
                            </li>
                            <li className="list-group-item">
                                Filtro sipas produkteve
                            </li>
                            <li className="list-group-item">
                                <input className="form-check-input me-1" type="checkbox" value="" aria-label="..." /> Pije
                            </li>
                            <li className="list-group-item">
                                <input className="form-check-input me-1" type="checkbox" value="" aria-label="..." /> Ushqim
                            </li>

                        </ul>
                    </div>
                    <div className="w-75 row row-cols-1 row-cols-md-3 g-3">

                        {menus.map(el => <div className="col">
                            <div className="card h-40">
                                <img src="https://images.unsplash.com/photo-1567620905732-2d1ec7ab7445?ixlib=rb-1.2.1&ixid=MnwxMjA3fDB8MHxleHBsb3JlLWZlZWR8NHx8fGVufDB8fHx8&w=1000&q=80" className="card-img-top" alt="Skyscrapers" />
                                <div className="card-body h-30">
                                    <h5 className="card-title">{el.emertimi}</h5>
                                    <h5 className="card-title">{el.cmimi} €</h5>
                                    <p className="card-text">{el.pershkrimi}</p>
                                </div>
                                <button type="button" value="LOGIN" class="btn btn-secondary btn-block">Porosit</button>
                            </div>
                        </div>
                        )}
                    </div>
                </div></>
        );
    }
}