from playwright.sync_api import sync_playwright

with sync_playwright() as p:
    browser = p.chromium.launch()
    page = browser.new_page()
    page.goto("http://localhost:5281/dataitems/create")
    page.screenshot(path="jules-scratch/verification/verification.png")
    browser.close()