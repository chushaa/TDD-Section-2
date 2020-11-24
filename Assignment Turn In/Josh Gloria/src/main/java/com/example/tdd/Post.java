package com.example.tdd;

public class Post {

	private int id;
	
	private String title;
	
	private String content;
	
	public Post(int id, String title, String content) {
		setId(id);
		setTitle(title);
		setContent(content);
	}

	public String getTitle() {
		return title;
	}

	public void setTitle(String title) {
		this.title = title;
	}

	public int getId() {
		return id;
	}

	public void setId(int id) {
		this.id = id;
	}

	public String getContent() {
		return content;
	}

	public void setContent(String content) {
		this.content = content;
	}
	

}
