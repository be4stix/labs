import logo from './logo.svg';
import './App.css';
import { useState } from 'react';
//lab13
//задание 1

function App1() {

function translit(word){
  var answer = '';
  var converter = {
    'а': 'a',    'б': 'b',    'в': 'v',    'г': 'g',    'д': 'd',
    'е': 'e',    'ё': 'e',    'ж': 'zh',   'з': 'z',    'и': 'i',
    'й': 'y',    'к': 'k',    'л': 'l',    'м': 'm',    'н': 'n',
    'о': 'o',    'п': 'p',    'р': 'r',    'с': 's',    'т': 't',
    'у': 'u',    'ф': 'f',    'х': 'h',    'ц': 'c',    'ч': 'ch',
    'ш': 'sh',   'щ': 'sch',  'ь': '',     'ы': 'y',    'ъ': '',
    'э': 'e',    'ю': 'yu',   'я': 'ya',
 
    'А': 'A',    'Б': 'B',    'В': 'V',    'Г': 'G',    'Д': 'D',
    'Е': 'E',    'Ё': 'E',    'Ж': 'Zh',   'З': 'Z',    'И': 'I',
    'Й': 'Y',    'К': 'K',    'Л': 'L',    'М': 'M',    'Н': 'N',
    'О': 'O',    'П': 'P',    'Р': 'R',    'С': 'S',    'Т': 'T',
    'У': 'U',    'Ф': 'F',    'Х': 'H',    'Ц': 'C',    'Ч': 'Ch',
    'Ш': 'Sh',   'Щ': 'Sch',  'Ь': '',     'Ы': 'Y',    'Ъ': '',
    'Э': 'E',    'Ю': 'Yu',   'Я': 'Ya'
  };
 
  for (var i = 0; i < word.length; ++i ) {
    if (converter[word[i]] == undefined){
      answer += word[i];
    } else {
      answer += converter[word[i]];
    }
  }
 
  return answer;
}

const [value,setValue] = useState("");
function handleChange (event) {
    setValue(event.target.value)
}
  return (
    <div>
        <textarea value={value} onChange={handleChange} />
        <p>{translit(value)}</p>
    </div>
  );
}


//Задание 2

function App2() {
const [checked,setChecked] = useState(true);
let massage;
if (checked){
  massage =<div>
<h2>Ура, вам уже есть 18</h2>
<p>
здесь расположен контент только для
взрослых
</p>
</div>
} else {
  massage = `<div>
<h2>Ура, вам уже есть 18</h2>
<p>
здесь расположен контент только для
взрослых
</p>
</div>`
}


  return(<div>
      <input type="checkbox" checked={checked} onChange={() => setChecked(!checked)}/>;
      <p>{massage}</p>
    </div>);
}



//Задание 3

function App3() {
    const texts = ['0-12лет','13-17лет', '18-25лет', '25+лет'];
    const [value,setValue] = useState("");
    const options = texts.map((text,index)=>{
      return <option key ={index}>{text}</option>;
    });

  return (<div>
        <select value={value} onChange={(event) => setValue(event.target.value)}>
        {options}</select>
    </div>);
}


//Задание 4

function App4(){
  const[value,setValue] = useState(true)

function handleChange (event) {
    setValue(event.target.value)
}
  return (<div>
      <input type="radio" name="radio" value="PHP" checked={value==="PHP"?true:false} onChange={handleChange}/> PHP<br />
      <input type="radio" name="radio" value="JAVA" checked={value==="JAVA"?true:false} onChange={handleChange}/> JAVA<br />
      <input type="radio" name="radio" value="REACT" checked={value==="REACT"?true:false} onChange={handleChange}/> REACT<br />

      <p>{value}</p>
    </div>)
}


//Задание 5

function App5(){
  const [massiv,setMassiv] = useState([1,2,3,4,5])

  let index = 2
  function redact(){
  let copy = Object.assign([],massiv);
  copy[index]='!'
  setMassiv(copy)
}
  return (<div>
    {massiv}<br/>
<button onClick={redact}>Изменить</button>
    </div>)
}
export default App5;
