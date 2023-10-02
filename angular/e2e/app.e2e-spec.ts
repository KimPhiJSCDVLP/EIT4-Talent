import { EIT4TalentTemplatePage } from './app.po';

describe('EIT4Talent App', function() {
  let page: EIT4TalentTemplatePage;

  beforeEach(() => {
    page = new EIT4TalentTemplatePage();
  });

  it('should display message saying app works', () => {
    page.navigateTo();
    expect(page.getParagraphText()).toEqual('app works!');
  });
});
