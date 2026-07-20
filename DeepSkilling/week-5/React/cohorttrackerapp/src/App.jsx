import styles from './CohortDetails.module.css';
const cohorts=[{code:'INTADMDF10',name:'ADM .NET FSD',status:'ongoing',start:'22-Feb-2026',coach:'John'},{code:'ADM21JF014',name:'Java FSD',status:'completed',start:'10-Jan-2026',coach:'Mary'}];
function CohortDetails({cohort}){return <div className={styles.box}><h3 style={{color:cohort.status==='ongoing'?'green':'blue'}}>{cohort.code}</h3><dl><dt>Name</dt><dd>{cohort.name}</dd><dt>Status</dt><dd>{cohort.status}</dd><dt>Start Date</dt><dd>{cohort.start}</dd><dt>Coach</dt><dd>{cohort.coach}</dd></dl></div>}
export default function App(){return <main className="app"><h1>Cohort Details</h1>{cohorts.map(c=><CohortDetails key={c.code} cohort={c}/>)}</main>}
