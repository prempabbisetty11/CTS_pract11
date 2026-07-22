import CohortDetails from './CohortDetails.jsx';
import {CohortData} from './Cohort.js';
export default function App(){return <main className="app"><h1>Cohort Test App</h1>{CohortData.map(cohort=><CohortDetails key={cohort.code} cohort={cohort}/>)}</main>}
