import { Link } from "react-router-dom";

const RestorantiRegister = () => {
    return (
        <div className="d-flex justify-content-center align-content-center">

            <form className="row g-3 d-flex w-50 mt-4 mb-3">
                <nav className="navbar bg-light">
                    <button className="btn btn-sm btn-outline-secondary" type="button"><Link to="/klientiregister" >Klient</Link></button>
                    <button className="btn btn-sm btn-outline-secondary" type="button"><Link to="/restorantiregister" >Restorant</Link></button>
                    <button className="btn btn-sm btn-outline-secondary" type="button"><Link to="/transportuesiregister" >Transportues</Link></button>
                </nav>
                <h1>Regjistrohu Si Restorant!</h1>
                <div className="col-sm-12 align-self">
                    <label for="inputEmail4" className="form-label">Email</label>
                    <input type="email" className="form-control" id="inputEmail4" />
                </div>
                <div className="col-sm-12">
                    <label for="inputPassword4" className="form-label">Password</label>
                    <input type="password" className="form-control" id="inputPassword4" />
                </div>
                <div className="col-sm-12">
                    <label for="emri" className="form-label">Emri</label>
                    <input type="email" className="form-control" id="emri" />
                </div>
                <div className="col-sm-12">
                    <label for="inputState" className="form-label">Qyteti</label>
                    <select id="inputState" className="form-select">
                        <option selected>Choose...</option>
                        <option>...</option>
                    </select>
                </div>
                <div className="col-sm-12">
                    <label for="adresa" className="form-label">Adresa</label>
                    <input type="text" className="form-control" id="adresa" />
                </div>
                <div className="col-sm-12">
                    <label for="nr_telefonit" className="form-label">Nr. Telefonit</label>
                    <input type="text" className="form-control" id="nr_telefonit" />
                </div>
                <div className="col-sm-12">
                    <label for="foto" className="form-label">Foto Profilit</label>
                    <input type="file" className="form-control" id="fotos" />
                </div>

                <div className="col-12">
                    <button type="submit" className="btn btn-primary">Regjistrohu</button>
                </div>
            </form>
        </div>
    );
}

export default RestorantiRegister;