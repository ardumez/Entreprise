import { EntreprisePage } from './app.po';

describe('entreprise App', () => {
  let page: EntreprisePage;

  beforeEach(() => {
    page = new EntreprisePage();
  });

  it('should display message saying app works', () => {
    page.navigateTo();
    expect(page.getParagraphText()).toEqual('app works!');
  });
});
