import React, { useState } from 'react'
import { Link, Redirect } from 'react-router-dom'

const DashboardKlienti = (props) => {
  /*if(props.name === ''){
        return <Redirect to="/" />
    }*/

  return (
    <div>
      <h4 className='mt-4'>Mirësevini {props.name}</h4>
      <ul className="nav nav-pills">
        <li className="nav-item bg-primary">
          <Link className="nav-link text-white" aria-current="page" to="/restorantetfavorite">
            Restorantet Favorite
          </Link>
        </li>
        <li className="nav-item">
          <a className="nav-link" href="#">
            Te dhenat e mia
          </a>
        </li>
        <li className="nav-item">
          <a className="nav-link" href="#">
            Porositë e mia
          </a>
        </li>
      </ul>
    </div>
  )
}

export default DashboardKlienti
