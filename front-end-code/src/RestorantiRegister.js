import { Link } from "react-router-dom";

const RestorantiRegister = () => {
    return (
        <div className="d-flex justify-content-center align-content-center">

            <form class="row g-3 d-flex w-50 mt-4 mb-3">
                <nav class="navbar bg-light">
                    <button class="btn btn-sm btn-outline-secondary" type="button"><Link to="/klientiregister" >Klient</Link></button>
                    <button class="btn btn-sm btn-outline-secondary" type="button"><Link to="/restorantiregister" >Restorant</Link></button>
                    <button class="btn btn-sm btn-outline-secondary" type="button"><Link to="/transportuesiregister" >Transportues</Link></button>
                </nav>
                <h1>Regjistrohu Si Restorant!</h1>
                <div class="col-sm-12 align-self">
                    <label for="inputEmail4" class="form-label">Email</label>
                    <input type="email" class="form-control" id="inputEmail4" />
                </div>
                <div class="col-sm-12">
                    <label for="inputPassword4" class="form-label">Password</label>
                    <input type="password" class="form-control" id="inputPassword4" />
                </div>
                <div class="col-sm-12">
                    <label for="emri" class="form-label">Emri</label>
                    <input type="email" class="form-control" id="emri" />
                </div>
                <div class="col-sm-12">
                    <label for="inputState" class="form-label">Qyteti</label>
                    <select id="inputState" class="form-select">
                        <option selected>Choose...</option>
                        <option>...</option>
                    </select>
                </div>
                <div class="col-sm-12">
                    <label for="adresa" class="form-label">Adresa</label>
                    <input type="text" class="form-control" id="adresa" />
                </div>
                <div class="col-sm-12">
                    <label for="nr_telefonit" class="form-label">Nr. Telefonit</label>
                    <input type="text" class="form-control" id="nr_telefonit" />
                </div>
                <div class="col-sm-12">
                    <label for="foto" class="form-label">Foto Profilit</label>
                    <input type="file" class="form-control" id="fotos" />
                </div>

                <div class="col-12">
                    <button type="submit" class="btn btn-primary">Regjistrohu</button>
                </div>
            </form>
        </div>
    );
}

export default RestorantiRegister;