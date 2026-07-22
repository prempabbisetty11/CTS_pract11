import {createContext,useContext,useState} from 'react';
const ThemeContext=createContext('light'); const employees=['Anu','Bala','Charan'];
function EmployeeCard({name}){const theme=useContext(ThemeContext); return <div className="panel"><h3>{name}</h3><button className={theme==='dark'?'secondary':''}>{theme} theme action</button></div>}
function EmployeesList(){return <div className="grid">{employees.map(name=><EmployeeCard key={name} name={name}/>)}</div>}
export default function App(){const [theme,setTheme]=useState('light');return <ThemeContext.Provider value={theme}><main className="app"><h1>Employee Management</h1><button onClick={()=>setTheme(t=>t==='light'?'dark':'light')}>Toggle Theme</button><EmployeesList/></main></ThemeContext.Provider>}
