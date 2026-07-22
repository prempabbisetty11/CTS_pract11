import React from 'react';

export default function CohortDetails({cohort}){return <section className="panel"><h3>{cohort.code}</h3><p>{cohort.name}</p><p>{cohort.status}</p><p>{cohort.coach}</p></section>}
