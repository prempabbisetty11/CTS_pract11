import {useState} from 'react';
const flights=['AI 202 Chennai to Delhi','6E 455 Bengaluru to Mumbai','UK 822 Hyderabad to Pune'];
function GuestPage(){return <section className="panel"><h2>Guest Page</h2><p>Browse available flights.</p>{flights.map(f=><p key={f}>{f}</p>)}</section>}
function UserPage(){return <section className="panel"><h2>User Page</h2><p>You can now book tickets.</p>{flights.map(f=><button key={f}>Book {f}</button>)}</section>}
export default function App(){const [loggedIn,setLoggedIn]=useState(false);return <main className="app"><h1>Ticket Booking App</h1>{loggedIn?<button className="secondary" onClick={()=>setLoggedIn(false)}>Logout</button>:<button onClick={()=>setLoggedIn(true)}>Login</button>}{loggedIn?<UserPage/>:<GuestPage/>}</main>}
