#!/bin/bash

version=$1
text=$2
branch=$(git rev-parse --abbrev-ref HEAD)
user_repo_name=$(git config --get remote.origin.url | sed 's/.*://;s/.git$//')
token=$(git config --global github.token)

generate_post_data()
{
  cat <<EOF
{
  "tag_name": "$version",
  "target_commitish": "$branch",
  "name": "$version",
  "body": "$text",
  "draft": false,
  "prerelease": false
}
EOF
}

echo "Create release $version for repo: $repo_full_name branch: $branch"
curl --data "$(generate_post_data)" "https://api.github.com/repos/$user_repo_name/releases?access_token=$token"

