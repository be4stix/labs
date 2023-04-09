/*import logo from './logo.svg';
import './App.css';
import {nanoid} from 'nanoid';
import React, { Component } from 'react';
import { useState } from 'react';
import { v4 as uuid } from 'uuid';
//lab12
//Задание 2
function App2() {
  return <div>
  <input /><br/>
  <input /><br/>
  <input /><br/>
  <input /><br/>
 
  </div>;
}

//Задание 3

function App3() {
const str1 = 'label';
const str2 = 'block';
const str3 = 'elem';
return <div>
<label id={str1} for={str2} className={str3} />text<label/> <br/>
<input id={str2} />
</div>;
}

//Задание 4
 function id()
 {
  return nanoid(4);
 }

 const prod = [
    {name:"product1",cost:100,id:id()},
    {name:"product2",cost:200,id:id()},
    {name:"product3",cost:300,id:id()}
  ];

function App4() {
  const res = prod.map(function(item) {
    return <p>{item.name} {item.cost} {item.id}</p>;
  });
  
  return <div>
    {res}
  </div>;
}

  

//задание 5

  function App5(){
const[ban,setBan] = useState('user')

  function click1(){
    setBan('user banned')
  }  
  function click2(){
    setBan('user unbanned')
  }

  return <div>
  <span>{ban}</span><br/>
  <button onClick={click1}>забанить</button>
  <button onClick={click2}>разбанить</button>
  </div>
}

//Задание 6

function App6(){
  const [value,setValue] = useState('Age')

    function handleChange(event){
      setValue(event.target.value)
    }

  return <div>
  <input value={value} onChange={handleChange} />
  <p>Year:{2022 - value}</p>
  </div>;
}

//Задание 7--

function App7(){
 
  const [days,setDays] = useState();
  const [time11,setTime11] = useState();
  const [time22,setTime22] = useState();

  function ChangeTime11(event){
    setTime11(event.target.value);
  }
  function ChangeTime22(event){
    setTime22(event.target.value);
  } 

  function time1(){
  let arr = time11.split('-');
  setTime11 ( new Date(arr[0], arr[1] , arr[2]))
}
  function time2(){
    let arr = time22.split('-');
    setTime22(new Date(arr[0],arr[1],arr[2]))
    alert(time22)
  }

 

  return (<div>
  <input value = {time11} onChange={ChangeTime11} onBlur={time1} /><br />
  <input value = {time22} onChange={ChangeTime22} onBlur={time2}/>
  <p>{Math.floor((time11-time22)/(1000 * 60 * 60 * 24))}</p>
  </div>);
}
 
export default App7;*/

import logo from './logo.svg';
import {nanoid} from 'nanoid';
import React, { Component } from 'react';
import { useState } from 'react';
import { v4 as uuid } from 'uuid';

function App1(){
  const [notes,setNotes] = useState(['a', 'b', 'c', 'd', 'e']); 
  const [value,setValue] = useState();

  const res = notes.map(note => {return <li>{note}</li>})


function handleChange(event){
  setValue(event.target.value)
}

  return (<div>
    <ul>
    {res}
    </ul>
    <input value={value} onChange={handleChange} onBlur={() => setNotes([...notes, value])} />
  </div>)
}

  function App3() {
const initProds = [
{name: 'product1', cost: 100,id:uuid()},
{name: 'product2', cost: 200,id:uuid()},
{name: 'product3', cost: 300,id:uuid()},
];
const [Prods, setProds] = useState(initProds);
 
function Delete(event){
let elems = document.querySelectorAll('tr')
let id = event.target.id;
 for(let elem of elems){
  if (id === elem.id){
      elem.remove();
   }
  }
 }

const r = Prods.map(note => {
return <tr id={note.id}>
<td>{note.name}</td>
<td>{note.cost}<button id = {note.id} onClick={Delete}>Удалить</button></td>
</tr>;
});

return <div>
<table>{r}</table>
<br />
</div>
}


function App4(){
  const initNotes = [
     {text:'a', isEdit:false},
     {text:'b', isEdit:false},
     {text:'c', isEdit:false},
     {text:'d', isEdit:false},
     {text:'e', isEdit:false},
     ];
  const [notes,setNotes] = useState(initNotes); 
 
  function startEdit(index) {
    const copy = Object.assign([], notes);
    copy[index].isEdit = true;
    setNotes(copy);
  }
  
  function endEdit(index) {
    const copy = Object.assign([], notes);
    copy[index].isEdit = false;
    setNotes(copy);
  }
  
  function changeNote(index, event) {
    const copy = Object.assign([], notes);
    copy[index].text = event.target.value;
    setNotes(copy);
  }

    const result = notes.map((note, index) => {
    let elem;
    
    if (!note.isEdit) {
      elem = <li>
        {note.text}
        <button onClick={() => startEdit(index)}>Редактировать</button>
      </li>;
    } else {
      elem = <input
        value={note.text}
        onChange={event => changeNote(index, event)}
        onBlur={() => endEdit(index)}
      />;
    }
        return <li key={index}>{elem}</li>;
  });


  return(<div>
    <ul>
    {result}
    </ul>
  </div>)
}

 
function App() {
  const initNotes = [
  {text: 'note1', isEdit: false},
  {text: 'note2', isEdit: false},
  {text: 'note3', isEdit: false},
];
  const [notes, setNotes] = useState(initNotes);
  
  function startEdit(index) {
    const copy = Object.assign([], notes);
    copy[index].isEdit = true;
    setNotes(copy);
  }
  
  function endEdit(index) {
    const copy = Object.assign([], notes);
    copy[index].isEdit = false;
    setNotes(copy);
  }
  
  function changeNote(index, event) {
    const copy = Object.assign([], notes);
    copy[index].text = event.target.value;
    setNotes(copy);
  }
  
  const result = notes.map((note, index) => {
    let elem;
    
    if (!note.isEdit) {
      elem = <span onClick={() => startEdit(index)}>
        {note.text}
      </span>;
    } else {
      elem = <input
        value={note.text}
        onChange={event => changeNote(index, event)}
        onBlur={() => endEdit(index)}
      />;
    }
    
    return <li key={index}>{elem}</li>;
  });

  return <ul>
    {result}
  </ul>;
}

export default App4;
