import React from 'react'
import { useEffect, useState } from 'react'

const Cart = ({ cart, setCart, handleChange }) => {
  const [price, setPrice] = useState(0)

  const handleRemove = (id) => {
    const arr = cart.filter((item) => item.menuID !== id)
    setCart(arr)
    handlePrice()
  }

  const handlePrice = () => {
    let ans = 0
    cart.map((item) => (ans += item.cmimi))
    setPrice(ans)
  }

  useEffect(() => {
    handlePrice()
  })

  let button = '';

  if(cart.length !== 0){
    button = (
      <button className='btn btn-primary w-25'><h5>Paguaj</h5></button>
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
          {cart.map((item) => (
            <tr key={item.menuID}>
              <th scope="row">{item.menuID}</th>
              <td>{item.emertimi}</td>
              <td>{item.cmimi}</td>
              <td>
                <button 
                  type="button"
                  className='btn btn-danger'
                  onClick={() => handleRemove(item.menuID)}>Remove</button>
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
