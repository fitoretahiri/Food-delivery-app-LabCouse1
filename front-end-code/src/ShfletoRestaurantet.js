import { Link } from "react-router-dom";
import React, { Component } from "react";
import { Navigation } from './Navigation';
import { AddRestorantModal } from './AddRestorantModal';
import { OrderFood } from "./OrderFood";
import restaurant from './Photos/restaurant.png';
import './Footer.js'
import Footer from "./Footer.js";


export class ShfletoRestaurantet extends Component {
    constructor(props) {
        super(props);
        this.state = { restorantet: [], addModalShow: false, editModalShow: false, restaurantID: "" }
        //this.state = { qytetet: [], addModalShow: false, editModalShow: false }
    }

    //marrja e te dhenave nga API
    refreshList() {
        fetch(process.env.REACT_APP_API + 'restaurant')
            .then(response => response.json())
            .then(data => {
                this.setState({ restorantet: data });
            });
    }

    /* refreshList() {
         fetch(process.env.REACT_APP_API + 'qyteti')
             .then(response => response.json())
             .then(data => {
                 this.setState({ qytetet: data });
             });
     }*/

    componentDidMount() {
        this.refreshList();
    }

    componentDidUpdate() {
        this.refreshList();
    }


    render() {
        const { restorantet, restaurantID, emri, data_regjistrimit, nrYjeve, foto, pershkrimi } = this.state;
        const { qytetet, qytetiID, emer } = this.state;
        let addModalClose = () => this.setState({ addModalShow: false });
        return (
            <>
                <Navigation />

                <form className="d-flex w-100 mt-4" role="search">
                    <input className="form-control me-2 border-3" type="search" placeholder="Search" aria-label="Search" />
                    <button className="btn btn-outline-success" type="submit">Search</button>
                </form>

                <div className="row row-cols-1 row-cols-md-2 g-3">
                    <div className="w-25 p-3 g-5">
                        <ul className="list-group">
                            <li className="list-group-item">
                                <input className="form-check-input me-1" type="checkbox" value="" aria-label="..." /> emri
                            </li>

                        </ul>
                    </div>
                    <div className="w-75 row row-cols-1 row-cols-md-3 g-3">

                        {restorantet.map(el => <div className="col">
                            <div className="card h-50" key={el.restaurantID}>
                                <img src={restaurant} className="card-img-top" alt="Skyscrapers" />
                                <div className="card-body h-30">
                                    <h5 className="card-title">{el.emri}</h5>
                                    <small>{el.nrYjeve} yje</small>
                                    <p>Gjendemi ne qytetin: {el.qyteti.emri}</p>
                                    <p className="card-text">{el.pershkrimi}</p>
                                </div>
                                <Link to={`/order`} onClick={() => { this.props.setId(el.restaurantID ) }} class="btn btn-secondary btn-block"> Zgjedh </Link>
                                <div className="card-footer">
                                    <small className="text-muted">{el.data_regjistrimit}</small>
                                </div>
                            </div>
                        </div>
                        )}
                    </div>
                    <Footer></Footer>
                </div></>
        );
    }
}