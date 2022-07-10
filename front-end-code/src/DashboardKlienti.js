import React, { useState, useEffect } from 'react'
import { Link, Redirect } from 'react-router-dom';
import AppNavbar from './AppNavbar';
import { Container, Row, Tabs, Tab } from 'react-bootstrap';
import { axiosPrivate } from './api/axios';

const DashboardKlienti = (props) => {
  const [user, setUser] = useState();
  const roles = localStorage.getItem('roles');
  const username = localStorage.getItem('username');
  const email = localStorage.getItem('email');

  return (
    <div>
      <AppNavbar />
      <Container className='py-4'>
        <h6>{username}</h6>
        <Row className='justify-content-center'>
          <Tabs justify variant='pills' defaultActiveKey="tab-1" className='mb-1 p-0 border'>
            <Tab eventKey="tab-1" title="Restorantet Favorite">
              Tab 1 Content
            </Tab>
            <Tab eventKey="tab-2" title="Te dhenat e mia">
              <form className='w-50 mx-auto mt-5'>
                <div class="input-group mb-3">
                  <span class="input-group-text" id="inputGroup-sizing-default">Username</span>
                  <input type="text" class="form-control" defaultValue={username} disabled={true} />
                </div>
                <div class="input-group mb-3">
                  <span class="input-group-text" id="inputGroup-sizing-default">Email</span>
                  <input type="text" class="form-control" defaultValue={email} disabled={true} />
                </div>
              </form>
            </Tab>
            <Tab eventKey="tab-3" title="Porositë e mia">
              Tab 3 Content
            </Tab>
          </Tabs>
        </Row>
      </Container>
    </div>
  )
}

export default DashboardKlienti
