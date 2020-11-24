package com.example.tdd;

import java.util.List;

import org.springframework.stereotype.Service;

@Service
public class NullBlogService implements BlogService {

	@Override
	public List<Post> findAll() {
		return null;
	}

}
