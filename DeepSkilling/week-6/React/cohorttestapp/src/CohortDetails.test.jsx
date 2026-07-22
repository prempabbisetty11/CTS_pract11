import React from 'react';
import { afterEach, describe, expect, test } from 'vitest';
import { cleanup, render, screen } from '@testing-library/react';
import CohortDetails from './CohortDetails.jsx';
import { CohortData } from './Cohort.js';

afterEach(cleanup);

describe('Cohort Details Component', () => {
  test('should create the component', () => { render(<CohortDetails cohort={CohortData[0]} />); expect(screen.getByText('ADM .NET FSD')).toBeTruthy(); });
  test('should initialize the props', () => { const cohort = CohortData[0]; expect(cohort.code).toBe('INTADMDF10'); });
  test('should display cohort code in h3', () => { render(<CohortDetails cohort={CohortData[0]} />); expect(screen.getByRole('heading', { level: 3 }).textContent).toBe('INTADMDF10'); });
  test('should always render same html', () => { const { container } = render(<CohortDetails cohort={CohortData[0]} />); expect(container).toMatchSnapshot(); });
});
