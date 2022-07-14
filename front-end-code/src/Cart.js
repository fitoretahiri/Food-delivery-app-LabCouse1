﻿import React from 'react'
import { useEffect, useState } from 'react'

const Cart = ({ cart, setCart, handleChange }) => {
    const [price, setPrice] = useState(0);
    //console.log(cart)
    const handleRemove = (id) => {
       // const arr = cart.filter((item) => item.menuID !== id)
        //setCart(arr)
        //handlePrice()
        if (window.confirm('A doni ta largoni produktin nga shporta?')) {
            fetch(process.env.REACT_APP_API + 'cart/' + id, {
                method: 'DELETE',
                header: {
                    'Accept': 'application/json',
                    'Content-Type': 'application/json'
                }
            })
        }
    }

    const [cartData, setCartData] = useState([]);

    const handlePrice = () => {
        let ans = 0
        cart.map((item) => (ans += item.menu.cmimi))
        setPrice(ans)
    }

    useEffect(() => {
        handlePrice();
        fetch(process.env.REACT_APP_API + 'cart/' + localStorage.getItem("id"))
            .then(response => response.json())
            .then(data => {
                setCartData(data);
                setCart(data);
            });

    }, [cartData]       
    )



    let button = '';

    if (cart.length !== 0) {
        button = (
            <button className='btn btn-primary w-25'><h5>Porosit</h5></button>
        )
    }

    return (
        <div>
            <table className="table">
                <tbody>
                    <tr>
                        <th>#</th>
                        <th>Emertimi</th>
                        <th>cmimi per njesi</th>
                        <th>Largo</th>
                    </tr>
                    {cartData.map((item) => (
                        <tr key={item.id}>
                            <th scope="row">{item.menuId}</th>
                            <td>{item.menu.emertimi}</td>
                            <td>{item.menu.cmimi}</td>
                            <td>
                                <button
                                    type="button"
                                    className='btn btn-danger'
                                    onClick={() => handleRemove(item.id)}>Remove</button>
                            </td>
                        </tr>
                    ))}
                </tbody>
            </table>
            <div className="total">
                <h5>
                    <span>Totali: </span>
                    <b><span>{price} €</span></b>
                </h5>
                {button}
            </div>
        </div>
    )
}

export default Cart