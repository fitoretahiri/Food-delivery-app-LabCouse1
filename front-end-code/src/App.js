import React from 'react';
import './App.css';
import { useEffect, useState } from "react";

import { Restoranti } from './Restoranti';
import { Qyteti } from './Qyteti';
import { Menu } from './Menu';
import { Roli } from './Roli/Roli';
import { UserRole } from './User-Role/UserRole';
import LoginForm from './LoginForm';
import TransportuesiRegister from './TransportuesiRegister';
import RestorantiRegister from './RestorantiRegister';
import KlientiRegister from './KlientiRegister';
import { Restaurant_Qyteti } from './Restaurant_Qyteti';
//import { Perdoruesi } from './Perdoruesi';
import DashboardRestoranti from './DashboardRestoranti';
import AppNavbar from './AppNavbar';
import { ShfletoRestaurantet } from './ShfletoRestaurantet';
import { OrderFood } from './OrderFood';
import { Pija } from './Pija';
import { Ushqimi } from './Ushqimi';
import { User } from './Users/User';
import Pagesa from './Pagesa';
import { Pagesa2 } from './Pagesa/Pagesa2';
//
import Unauthorized from './Unauthorized'
import { Routes, Route } from 'react-router-dom';
import Layout from './components/Layout';
import RequireAuth from './RequireAuth';
import Missing from './Missing';
import Admin from './Admin';
import PersistLogin from './components/PersistLogin';


import DashboardKlienti from './DashboardKlienti';
import RestorantetFavorite from './RestorantetFavorite';
import Cart from './Cart';
import Kontakto from './Kontakto'

function App() {

    const [show, setShow] = useState(true);
    const [cart, setCart] = useState([]);



    const [id, setId] = useState('')

    const handleClick = (item) => {
        console.log(item)
        if (cart.indexOf(item) !== -1) return;
        setCart([...cart, item]);
    }

    const handleChange = (item, d) => {
        const ind = cart.indexOf(item);
        const arr = cart;

        arr[ind].amount += d;

        if (arr[ind].amount === 0) arr[ind].amount = 1;
        setCart([...arr]);
    };

    return (
        <Routes>

            <Route path="/" element={<Layout show={show} setShow={setShow} cart={cart} />}>

                {/*public routes */}
                <Route path="shfletorestorantet" element={<ShfletoRestaurantet setId={setId} />} />
                <Route path="/order" element={<OrderFood handleClick={handleClick} id={id} show={show} cart={cart} handleChange={handleChange} setCart={setCart} />} />
                <Route path='cart' element={<Cart cart={cart} handleChange={handleChange} setCart={setCart} show={show} />} />
                <Route path="klientiregister" element={<KlientiRegister />} />
                <Route exact path="/" element={<LoginForm />} />
                <Route path="transportuesiregister" element={<TransportuesiRegister />} />
                <Route path="restorantiregister" element={<RestorantiRegister />} />
                <Route path="unauthorized" element={<Unauthorized />} />
                <Route path="/klientidashboard" element={<DashboardKlienti />} />
                <Route path="admin" element={<Admin />} />
                <Route path="qyteti" element={<Qyteti />} />
                <Route path="users" element={<User />} />
                <Route path="userrole" element={<UserRole />} />
                <Route path="roles" element={<Roli />} />
                <Route path="restaurant_qyteti" element={<Restaurant_Qyteti />} />
                <Route path="pija" element={<Pija />} />
                <Route path="ushqimi" element={<Ushqimi />} />
                <Route path="pagesa" elementt={<Pagesa />} />
                <Route path="pagesaDashboard" element={<Pagesa2 />} />
                <Route path="restaurant" element={<Restoranti />} />
                <Route path="restorantidashboard" element={<DashboardRestoranti />} />
                <Route path="menu" element={<Menu />} />
                <Route path="kontakto" element={<Kontakto />} />



                {/*we want to protext these routes */}
                <Route element={<PersistLogin />}>
                    <Route element={<RequireAuth allowedRoles={['Klient']} />}>

                    </Route>

                    <Route element={<RequireAuth allowedRoles={['Restorant']} />}>

                    </Route>

                    <Route element={<RequireAuth allowedRoles={['Administrator']} />}>

                    </Route>
                    <Route element={<RequireAuth allowedRoles={['Administrator', 'Klient', 'Restorant']} />}>
                    </Route>
                </Route>

                {/*catch all */}
                {/*<Route path="*" element={<Missing />} /> */}
            </Route>
        </Routes>
    );
}

export default App;
