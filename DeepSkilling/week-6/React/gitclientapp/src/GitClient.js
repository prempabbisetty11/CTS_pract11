import axios from 'axios';
export default class GitClient {
  static async getRepositories(userName) {
    const response = await axios.get('https://api.github.com/users/' + userName + '/repos');
    return response.data.map(repo => repo.name);
  }
}
