import React, { Component } from 'react';
import { Table } from 'react-bootstrap';
import {Button, ButtonToolbar} from 'react-bootstrap';
import { AddQytetinModal } from './AddQytetinModal';
import { EditQytetinModal } from './EditQytetinModal';


export class Qyteti extends Component {
    constructor(props) {
        super(props);
        this.state = { qytetet: [], addModalShow: false}
    }

    //marrja e te dhenave nga API
    refreshList() {
        fetch(process.env.REACT_APP_API + 'qyteti')
            .then(response => response.json())
            .then(data => {
                this.setState({ qytetet: data });
            });
    }

    componentDidMount() {
        this.refreshList();
    }

    componentDidUpdate() {
        this.refreshList();
    }

    deleteQytetin(id){
        if(window.confirm('A doni ta fshini qytetin?')){
            fetch(process.env.REACT_APP_API+'qyteti/'+id,{
                method:'DELETE',
                header:{'Accept':'application/json',
            'Content-Type':'application/json'}
            })
        }
    }

    render() {
        const { qytetet } = this.state;
        let addModalClose=()=>this.setState({addModalShow:false});
        let editModalClose=()=>this.setState({editModalShow:false});
        return (
            <div className="mt-5">
                <Table className="mt-4" striped bordered hover size="sm">
                    <thead>
                        <tr>
                            <th>Id</th>
                            <th>Emri</th>
                        </tr>
                    </thead>
                    <tbody>
                        {qytetet.map(el =>
                            <tr key={el.id}>
                                <td>1</td>
                                <td>Prishtine</td>
                                <td>
                                <ButtonToolbar>
    <Button className="mr-2" variant="info"
    onClick={()=>this.setState({editModalShow:true,
        id:el.Id,emri:el.emri})}>
            Edit
        </Button>

        <Button className="mr-2" variant="danger"
    onClick={()=>this.deleteQytetin(el.id)}>
            Delete
        </Button>

        <EditQytetinModal show={this.state.editModalShow}
        onHide={editModalClose}
        id={el.id}
        emri={el.emri}/>
</ButtonToolbar>

                                </td>

                            </tr>)}
                            <tr>
                                <td>1</td>
                                <td>Prishtine</td>
                                <td>
                                <ButtonToolbar>
    <Button className="mr-2" variant="info">
            Edit
        </Button>

        <Button className="mr-2" variant="danger">
            Delete
        </Button>
</ButtonToolbar>

                                </td>

                            </tr>
                            <tr>
                                <td>2</td>
                                <td>Gjilan</td>
                                <td>
                                <ButtonToolbar>
    <Button className="mr-2" variant="info">
            Edit
        </Button>

        <Button className="mr-2" variant="danger">
            Delete
        </Button>
</ButtonToolbar>

                                </td>
                            </tr>
                    </tbody>

                </Table>
                <ButtonToolbar>
                <div className="d-grid gap-2">
                    <Button variant='primary' size='lg'
                    onClick={()=>{this.setState({addModalShow:true})}}>
                    Shto Qytetin
                    </Button>
                </div>
                    <AddQytetinModal show={this.state.addModalShow}
                    onHide={addModalClose}></AddQytetinModal>
                </ButtonToolbar>
            </div>
        )
    }
}