package com.example.tdd;

import java.util.List;

import org.springframework.beans.factory.annotation.Autowired;
import org.springframework.http.ResponseEntity;
import org.springframework.web.bind.annotation.GetMapping;
import org.springframework.web.bind.annotation.RestController;

@RestController
public class BlogController {

	@Autowired
	private BlogService blogService;
	
	@GetMapping("/posts")
	public ResponseEntity<List<Post>> get() {
		return ResponseEntity
				.ok()
				.body(blogService.findAll());
	}

}
