User
-----
_id
name
email
password

Article
--------
_id
title
description
createdAt
updatedAt
userId (refers to User._id)

Block
-----
_id
type
value
createdAt
updatedAt
articleId (refers to Article._id)
