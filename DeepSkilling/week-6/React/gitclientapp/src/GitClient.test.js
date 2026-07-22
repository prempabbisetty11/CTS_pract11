import { describe, expect, test, vi } from 'vitest';
import axios from 'axios';
import GitClient from './GitClient.js';
vi.mock('axios');
describe('Git Client Tests', () => {
  test('should return repository names for techiesyed', async () => {
    axios.get.mockResolvedValue({ data: [{ name: 'react-demo' }, { name: 'api-client' }] });
    await expect(GitClient.getRepositories('techiesyed')).resolves.toEqual(['react-demo', 'api-client']);
  });
});
