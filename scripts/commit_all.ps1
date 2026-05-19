# Commit all changes script
# Run this from inside your repository folder in PowerShell.

if (-not (Get-Command git -ErrorAction SilentlyContinue)) {
    Write-Error "Git is not installed or not in PATH. Install Git and try again: https://git-scm.com/download/win"
    exit 1
}

$gitTop = git rev-parse --show-toplevel 2>$null
if ($LASTEXITCODE -ne 0) {
    Write-Host "Not inside a git repository. Change to the repository folder and re-run this script."
    exit 1
}

# Ensure user config exists
$userName = git config user.name
if (-not $userName) {
    $name = Read-Host "Git user.name not set. Enter your name to set globally (or leave blank to skip)"
    if ($name) { git config --global user.name "$name" }
}

$userEmail = git config user.email
if (-not $userEmail) {
    $email = Read-Host "Git user.email not set. Enter your email to set globally (or leave blank to skip)"
    if ($email) { git config --global user.email "$email" }
}

# Ensure remote origin exists
$hasOrigin = git remote | Select-String -Pattern '^origin$' -Quiet
if (-not $hasOrigin) {
    $remoteUrl = Read-Host "No remote 'origin' found. Enter remote URL to add (or leave blank to skip)"
    if ($remoteUrl) { git remote add origin $remoteUrl }
}

$msg = Read-Host "Commit message (default: 'Commit all changes')"
if (-not $msg) { $msg = "Commit all changes" }

Write-Host "Staging all changes..."
git add -A
if ($LASTEXITCODE -ne 0) { Write-Error "git add failed."; exit 1 }

Write-Host "Committing..."
git commit -m "$msg"
if ($LASTEXITCODE -ne 0) {
    Write-Host "Nothing to commit or commit failed. If there were no changes, that's fine."
} else {
    Write-Host "Pushing to origin/main..."
    git push -u origin main
    if ($LASTEXITCODE -ne 0) { Write-Error "git push failed. Check remote/authentication."; exit 1 }
    Write-Host "Push complete."
}
