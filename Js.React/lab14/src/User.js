function User(users) {

function ban(event){
let elems = document.querySelectorAll('tr')
console.log(elems)
let id = event.target.id;
console.log(id)
 for(let elem of elems){
 	console.log(elem)
 	if (id === elem.id){
 		elem.style.color = 'red'
 	}
 }
}

return <tr id={users.id}>
<td>Пользователь</td>
<td > {users.name} </td>
<td> {users.surname} </td>
<td> {users.age} </td>
<td> {users.id} </td>
<td><button id={users.id} onClick={ban}>Забанить</button></td>
</tr>;
}

export default User;