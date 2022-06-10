import { Link } from "react-router-dom";
import React, { Component } from "react";

export class TransportuesiRegister extends Component {
    constructor(props) {
        super(props);
        this.handleSubmit = this.handleSubmit.bind();
    }

    addTransportuesi(){
        console.log("hello")
    }

    handleSubmit(event) {
        fetch(process.env.REACT_APP_API + 'perdoruesi', {
            method: 'POST',
            headers: {
                'Accept': 'application/json',
                'Content-Type': 'application/json'
            },
            body: JSON.stringify({
                email: event.target.email.value,
                emri: event.target.emri.value + " " + event.target.mbiemri.value,
                password: event.target.password.value,
                qyteti: "Prishtinë",
                adresa: event.target.adresa.value,
                nr_telefonit: event.target.nr_telefonit.value,
                photoProfile: "C:\\fakepath\\use-case-diag.jpg",
                roliID: 2
            })
            
        })
            .then(res => res.json())
            .then((result) => {
                console.log("id e perdoruesit: "+result.perdoruesiID)
                alert(result.status);
                fetch(process.env.REACT_APP_API + 'transportuesi', {
                    method: 'POST',
                    headers: {
                        'Accept': 'application/json',
                        'Content-Type': 'application/json'
                    },
                    body: JSON.stringify({
                        nrPorosive: 1,
                        dataLindjes: "2004-05-23T00:00:00",
                        statusi_aktivitetit: 1,
                        perdoruesiID: result.perdoruesiID
        
                    })
                })
                    .then(res => res.json())
                    .then((result) => {
                        alert(result);
                    },
                        (error) => {
                            alert('Failed');
                        })
            },
                (error) => {
                    alert('Failed');
                })
    }
    render() {
        return (
            <div className="d-flex justify-content-center align-content-center">

                <form className="row g-3 d-flex w-50 mt-4 mb-3" onSubmit={this.handleSubmit}>
                    <nav className="navbar bg-light">
                        <button className="btn btn-sm btn-outline-secondary" type="button"><Link to="/klientiregister" >Klient</Link></button>
                        <button className="btn btn-sm btn-outline-secondary" type="button"><Link to="/restorantiregister" >Restorant</Link></button>
                        <button className="btn btn-sm btn-outline-secondary" type="button"><Link to="/transportuesiregister" >Transportues</Link></button>
                    </nav>
                    <h1>Regjistrohu Si Transportues!</h1>
                    <div class="col-sm-12 align-self">
                        <label className="form-label">Email</label>
                        <input type="email" className="form-control" id="inputEmail4" name="email" />
                    </div>
                    <div class="col-sm-12">
                        <label className="form-label">Password</label>
                        <input type="password" className="form-control" id="inputPassword4" name="password" />
                    </div>
                    <div class="col-sm-12">
                        <label className="form-label">Emri</label>
                        <input type="text" className="form-control" id="emri" name="emri" />
                    </div>
                    <div class="col-sm-12">
                        <label className="form-label">Mbiemri</label>
                        <input type="text" className="form-control" id="mbiemri" name="mbiemri" />
                    </div>
                    <div class="col-sm-12">
                        <label className="form-label">Qyteti</label>
                        <select id="inputState" className="form-select">
                            <option defaultValue>Choose</option>
                            <option>...</option>
                        </select>
                    </div>
                    <div class="col-sm-12">
                        <label className="form-label">Adresa</label>
                        <input type="text" className="form-control" id="adresa" name="adresa" />
                    </div>
                    <div class="col-sm-12">
                        <label className="form-label">Nr. Telefonit</label>
                        <input type="text" className="form-control" id="nr_telefonit" />
                    </div>
                    <div className="col-sm-12">
                        <label >Data Lindjes</label>
                        <input id="data_lindjes" className="form-control" type="date" name="data_lindjes" />
                    </div>
                    <div class="col-sm-12">
                        <label  className="form-label">Foto Profilit</label>
                        <input type="file" className="form-control" id="foto" name="foto_profilit" />
                    </div>

                    <div className="col-12">
                        <button type="submit" className="btn btn-primary">Regjistrohu</button>
                    </div>
                </form>
            </div>
        );
    }
}