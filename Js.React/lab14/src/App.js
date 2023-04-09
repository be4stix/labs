import logo from './logo.svg';
import './App.css';
import { useState } from 'react';
import User from './User'
import {nanoid} from 'nanoid'
//Задание 1
 
function App1() {
const [notes,setNotes] = useState(['a', 'b', 'c', 'd', 'e']); 
const [value,setValue] = useState("");
const[i,setI]= useState();
function handleChange(event){
      setValue(event.target.value)
}

function redaction(){
  setValue()
}
  function redact(){
  let copy = Object.assign([],notes);
  copy[i]=value
  setNotes(copy)

}
const[notes1,setNodes] = useState({notes})
  return (
    <div >
    <ul>
       <li>{notes[0]} <button onClick={event=>(setValue(notes[0]),setI(0))}>Редактировать</button></li>
       <li>{notes[1]} <button onClick={event=>(setValue(notes[1]),setI(1))}>Редактировать</button></li>
       <li>{notes[2]} <button onClick={event=>(setValue(notes[2]),setI(2))}>Редактировать</button></li>
       <li>{notes[3]} <button onClick={event=>(setValue(notes[3]),setI(3))}>Редактировать</button></li>
       <li>{notes[4]} <button onClick={event=>(setValue(notes[4]),setI(4))}>Редактировать</button></li>
      </ul>
      <input value={value} onChange={handleChange} onBlur={redact}/>
    </div>
  );
} 


//Задание 2

 

const initNotes = [
  {
    id: 'GYi9G_uC4gBF1e2SixDvu',
    prop1: 'value11',
    prop2: 'value12',
    prop3: 'value13',
  },
  {
    id: 'IWSpfBPSV3SXgRF87uO74',
    prop1: 'value21',
    prop2: 'value22',
    prop3: 'value23',
  },
  {
    id: 'JAmjRlfQT8rLTm5tG2m1L',
    prop1: 'value31',
    prop2: 'value32',
    prop3: 'value33',
  },
];

const value = {
  id: 'JAmjRlfQT8rLTm5tG2m1L',
  prop1: 'value21 !!!',
  prop2: 'value22 !!!',
  prop3: 'value23 !!!',
};

function App2() {
  const [notes, setNotes] = useState(initNotes);
  
  const result = notes.map(note => {
    return <p key={note.id}>
      <span>{note.prop1}</span>,
      <span>{note.prop2}</span>,
      <span>{note.prop3}</span>
    </p>;
  });

function redact(){
  setNotes(notes.map(note => {
  if (note.id === value.id) {
    return value;
  } else {
    return note;
  }
}));}

  return <div>
    {result}
    <button onClick={redact}>Редактировать</button>
  </div>;
}
  
function App3() {
const initProds = [
{name: 'product1', cost: 100},
{name: 'product2', cost: 200},
{name: 'product3', cost: 300},
];
const [Prods, setProds] = useState(initProds);
const [obj, setObj] = useState(getInitObj());
const [editId, setEditId] = useState(null);
const r = Prods.map(note => {
return <tr key={note.id}>
<td>{note.name}</td>
<td>{note.cost}</td>
</tr>;
});
function getValue(prop) {
if (editId) {
return Prods.map((res, note) => note.id === editId ? note[prop]
: res, '');
} else {
return obj[prop];
}
}
function changeItem(prop, event) {
if (editId) {
setProds(Prods.map(note =>
note.id === editId ? {...note, [prop]: event.target.value}
: note
));
} else {
setObj({...obj, [prop]: event.target.value});
}
}
function saveItem() {
if (editId) {
setEditId(null);
} else {
setProds([...Prods, obj]);
setObj(getInitObj());
}
}

return <div>
<table>{r}</table>
<br />
<input
value={getValue('name')}
onChange={event => changeItem('name', event)}
/>
<input
value={getValue('cost')}
onChange={event => changeItem('cost', event)}
/>
<button onClick={saveItem}>save</button>
</div>
}

function getInitObj() {
return {
name: '',
cost: ''
}}

function App4 () {
const [value, setValue] = useState('text');
const [isEdit, setIsEdit] = useState(false);

let elem;
if (!isEdit) {
elem = <span onClick={() => setIsEdit(true)}>
{value}

</span>;
} else {
elem = <input
value={value}
onChange={event => setValue(event.target.value)}
/>;
}

return <p>
{elem}<br />
<button onClick={() => setIsEdit(true)}>редактировать</button>
<button onClick={() => setIsEdit(false)}>не редактировать</button>
</p>;
}



function App5(){
const users = [
{name: 'Давид', surname: 'Базевич', age: '18', id:id()},
{name: 'Сергей', surname: 'Кондерешко', age: '17',id:id()},
{name: 'Денис', surname: 'Комар', age: '20',id:id()},
];

function id(){
  let el = nanoid(5)
  console.log()
  return el
}



const fio = users.map(user => {return <User name={user.name} surname={user.surname} age={user.age} id={user.id} />});

return (<div> 
  {fio}
  </div>)
}



export default App5;