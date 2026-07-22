import {useEffect,useState} from 'react';
import GitClient from './GitClient.js';
export default function App(){const [repos,setRepos]=useState([]); useEffect(()=>{GitClient.getRepositories('techiesyed').then(setRepos).catch(()=>setRepos([]));},[]); return <main className="app"><h1>Git Client App</h1><section className="panel"><h2>Repositories for techiesyed</h2>{repos.map(repo=><p key={repo}>{repo}</p>)}</section></main>}
