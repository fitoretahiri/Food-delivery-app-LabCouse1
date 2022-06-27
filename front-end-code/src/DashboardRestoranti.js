import { Link } from 'react-router-dom'

const DashboardRestoranti = (props) => {
  return (
    <div>
      <h1>
        {props.name
          ? 'Jeni Kyqur me sukses: ' + props.name
          : 'Ju nuk jeni i kyqur'}{' '}
      </h1>
      <div>
        <h4 className="mt-4">Mirësevini {props.name}</h4>
        <ul className="nav nav-pills">
          <li className="nav-item">
            <a className="nav-link" href="#">
              Te dhenat e Restorantit
            </a>
          </li>
          <li className="nav-item">
            <a className="nav-link" href="#">
              Porositë
            </a>
          </li>
        </ul>
        <form class="row g-3">
          <div class="col-md-6">
            <label for="inputEmail4" class="form-label">
              Email
            </label>
            <input type="email" class="form-control" id="inputEmail4" />
          </div>
          <div class="col-md-6">
            <label for="inputPassword4" class="form-label">
              Password
            </label>
            <input type="password" class="form-control" id="inputPassword4" />
          </div>
          <div class="col-12">
            <label for="username" class="form-label">
              username
            </label>
            <input
              type="text"
              class="form-control"
              placeholder="Restorant username"
            />
          </div>
          <div class="col-12">
            <label for="inputAddress2" class="form-label">
              Adresa
            </label>
            <input
              type="text"
              class="form-control"
              placeholder="Lagjja, Rruga, Numri"
            />
          </div>
          <button type="button" class="btn btn-info btn-block">
            Shto adresë të re
          </button>
          <label for="" class="form-label">
              Qyteti
            </label>
          <select class="btn btn-block form-control border">
            <option>Qyteti</option>
            <option>Prishtinë</option>
          </select>
          <button type="button" class="btn btn-info btn-block">
            Shto qytet të ri
          </button>
          <div class="col-12">
            <label for="inputAddress2" class="form-label">
              Nr. Kontaktues 1
            </label>
            <input type="text" class="form-control" placeholder="Qyteti" />
          </div>
          <button type="button" class="btn btn-info btn-block">
            Shto nr. kontaktues te ri
          </button>
          <div class="col-12">
            <button type="submit" class="btn btn-primary">
              Update
            </button>
          </div>
        </form>
      </div>
    </div>
  )
}

export default DashboardRestoranti
